using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Common.Controls;
using Common.Controls.Timeline;
using Vixen.Module.Effect;
using Vixen.Services;
using WeifenLuo.WinFormsUI.Docking;
using VixenModules.Sequence.Timed;
using VixenModules.SequenceType.Timed;

namespace VixenModules.Editor.TimedSequenceEditor
{
	public partial class Form_SavedEffects : DockContent
	{
        public Form_SavedEffects(TimelineControl timelineControl)
		{
			InitializeComponent();
			TimelineControl = timelineControl;
		}
        private static readonly DataFormats.Format _clipboardFormatName =
            DataFormats.GetFormat(typeof(TimelineElementsClipboardData).FullName);

        private void Form_SavedEffects_Load(object sender, EventArgs e)
		{
			var xml = new XMLProfileSettings();
            //numericUpDownStandardNudge.Value = xml.GetSetting(XMLProfileSettings.SettingType.AppSettings, string.Format("{0}/StandardNudge", Name), 10);
            //numericUpDownSuperNudge.Value = xml.GetSetting(XMLProfileSettings.SettingType.AppSettings, string.Format("{0}/SuperNudge", Name), 20); ;
            ////xml = null;
		}

		public TimelineControl TimelineControl { get; set; }

		public void PopulateSavedEffectsCollectionsList(SavedEffectsCollection selectedCollection)
		{
			listViewSavedEffectsCollections.Items.Clear();
            foreach (SavedEffectsCollection sec in Sequence.SavedEffectsCollections)
			{
				ListViewItem item = new ListViewItem();
                item.Text = sec.Name;
                item.SubItems.Add(sec.Level.ToString());
                item.SubItems.Add(sec.Effects.ToString());
                item.BackColor = (sec.Enabled) ? sec.SavedEffectColor : SystemColors.Window;
                item.ForeColor = (sec.Enabled)
                                    ? ((GetGrayValueForColor(sec.SavedEffectColor) > 128) ? Color.Black : Color.White)
                                    : SystemColors.InactiveCaptionText;
                
                item.Tag = sec;
                item.Checked = sec.Enabled;
				listViewSavedEffectsCollections.Items.Add(item);
				item.Selected = (sec == selectedCollection);
			}
		}

		public SavedEffectsCollection SelectedSavedEffectsCollection
		{
			get
			{
                if (listViewSavedEffectsCollections.SelectedItems.Count > 0)
				{
                    SavedEffectsCollection item = listViewSavedEffectsCollections.SelectedItems[0].Tag as SavedEffectsCollection;
					return item;
				}
				else
				{
					return null;
				}
			}
		}

        private double GetGrayValueForColor(Color c)
        {
            return c.R * 0.299 + c.G * 0.587 + c.B * 0.114;
        }

		public TimedSequence Sequence { get; set; }

        public event EventHandler<SavedEffectCollectionArgs> SavedEffectsCollectionsChecked;
        protected virtual void OnSavedEffectsCollectionChecked(SavedEffectCollectionArgs e)
        {
            if (SavedEffectsCollectionsChecked != null)
                SavedEffectsCollectionsChecked(this, e);
        }

        //public event EventHandler<EventArgs> EditMarkCollection;
        //protected virtual void OnEditMarkCollection(EventArgs e)
        //{
        //    if (EditMarkCollection != null)
        //        EditMarkCollection(this, e);
        //}

        public event EventHandler<SavedEffectCollectionArgs> ChangedSavedEffectsCollection;
        protected virtual void OnChangedSavedEffectsCollection(SavedEffectCollectionArgs e)
        {
            if (ChangedSavedEffectsCollection != null)
                ChangedSavedEffectsCollection(this, e);
        }

        private void listViewSavedEffectsCollections_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Point mousePoint = PointToClient(new Point(MousePosition.X, MousePosition.Y));
            ListViewItem mouseItem = listViewSavedEffectsCollections.GetItemAt(mousePoint.X, mousePoint.Y);
            ListViewItem item = listViewSavedEffectsCollections.Items[e.Index];
            SavedEffectsCollection sec = item.Tag as SavedEffectsCollection;
            sec.Enabled = (e.NewValue == CheckState.Checked);
            OnChangedSavedEffectsCollection(new SavedEffectCollectionArgs(sec));
        }

        //private void toolStripButtonEditMarkCollection_Click(object sender, EventArgs e)
        //{
        //    OnEditMarkCollection(EventArgs.Empty);
        //}

		private void listViewSavedEffectsCollections_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			SavedEffectsCollection sec = (listViewSavedEffectsCollections.Items[e.Item].Tag as SavedEffectsCollection);
            sec.Name = e.Label ?? sec.Name;
            OnChangedSavedEffectsCollection(new SavedEffectCollectionArgs(sec));
		}

		private void toolStripButtonAddSavedEffectCollection_Click(object sender, EventArgs e)
		{

            IDataObject dataObject = Clipboard.GetDataObject();
            TimelineElementsClipboardData data;
            SavedEffectsCollection sec = new SavedEffectsCollection();
            sec.Name = "New Saved Effect";
            if (dataObject != null)
            {
                if (dataObject.GetDataPresent(_clipboardFormatName.Name))
                {
                    data = dataObject.GetData(_clipboardFormatName.Name) as TimelineElementsClipboardData;
                   // Dictionary<IEffectModuleInstance> tes = data.EffectModelCandidates;
                  //  EffectModelCandidatess = new Dictionary<EffectModelCandidate, int>();

                    sec.Effects = data.EffectModelCandidates.Select(kvp => kvp.Key).ToList();
              

              
              
                

                Sequence.SavedEffectsCollections.Add(sec);
                OnChangedSavedEffectsCollection(new SavedEffectCollectionArgs(sec));
                PopulateSavedEffectsCollectionsList(sec);
                }
                else
                {
                    //no clipboard data we wont create an effect.  Should probally dialog
                }
            }
		}

		private void toolStripButtonDeleteSavedEffectCollection_Click(object sender, EventArgs e)
		{
			if (listViewSavedEffectsCollections.SelectedItems.Count > 0)
			{
				SavedEffectsCollection sec = (listViewSavedEffectsCollections.SelectedItems[0].Tag as SavedEffectsCollection);
				if (MessageBox.Show("Are you sure you want to delete the selected saved effect ?", "Delete Saved Effect", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
				{
					listViewSavedEffectsCollections.SelectedItems[0].Remove();
                    Sequence.SavedEffectsCollections.Remove(sec);
                    OnChangedSavedEffectsCollection(new SavedEffectCollectionArgs(null));
				}
			}
			else
			{
				MessageBox.Show("Please select a Saved Effect to delete and press the delete button again.", "Delete Saved Effect Collection", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
		}

        //private void numericUpDownStandardNudge_ValueChanged(object sender, EventArgs e)
        //{
        //    TimelineControl.ruler.StandardNudgeTime = Convert.ToInt32(numericUpDownStandardNudge.Value);
        //}

        //private void numericUpDownSuperNudge_ValueChanged(object sender, EventArgs e)
        //{
        //    TimelineControl.ruler.SuperNudgeTime = Convert.ToInt32(numericUpDownSuperNudge.Value);
        //}

        private void Form_SavedEffects_Closing(object sender, FormClosingEventArgs e)
        {
            var xml = new XMLProfileSettings();
            //xml.PutSetting(XMLProfileSettings.SettingType.AppSettings, string.Format("{0}/StandardNudge", Name), Convert.ToInt32(numericUpDownStandardNudge.Value));
            //xml.PutSetting(XMLProfileSettings.SettingType.AppSettings, string.Format("{0}/SuperNudge", Name), Convert.ToInt32(numericUpDownSuperNudge.Value));
        }

	}

	public class SavedEffectCollectionArgs: EventArgs
	{
        public SavedEffectCollectionArgs(SavedEffectsCollection sec)
		{
            SavedEffectCollection = sec;
		}

		public SavedEffectsCollection SavedEffectCollection { get; private set; }
	}

}
