using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;
using Vixen.Module.Effect;
using VixenModules.SequenceType.Timed;


namespace VixenModules.Sequence.Timed
{
	[DataContract]
	public class SavedEffectsCollection
	{
        public SavedEffectsCollection()
		{
			Effects = new List<EffectModelCandidate>();
			Id = Guid.NewGuid();
			
		}

		public SavedEffectsCollection(SavedEffectsCollection original)
		{
			Effects = new List<EffectModelCandidate>(original.Effects);
			Id = Guid.NewGuid();
			Name = original.Name;
		}

		[DataMember]
		public string Name { get; set; }

        [DataMember]
        public bool Enabled { get; set; }

		[DataMember]
        public List<EffectModelCandidate> Effects { get; set; }

        [DataMember]
        public Color SavedEffectColor { get; set; }

        [DataMember]
        public int Level { get; set; }

		[DataMember]
		public Guid Id { get; set; }

		public int EffectCount
		{
			get { return Effects.Count; }
		}

        //public int IndexOf(TimeSpan time)
        //{
        //    return Marks.IndexOf(time);
        //}
	}
}