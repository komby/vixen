using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using Vixen.Module;
using Vixen.Module.Effect;

namespace VixenModules.SequenceType.Timed
{
    [Serializable]
    public class EffectModelCandidate
    {
           private readonly Type _moduleDataClass;
           private readonly MemoryStream _effectData;
         public EffectModelCandidate(IEffectModuleInstance effect)
            {
                _moduleDataClass = effect.Descriptor.ModuleDataClass;
                DataContractSerializer ds = new DataContractSerializer(_moduleDataClass);

                TypeId = effect.Descriptor.TypeId;
                _effectData = new MemoryStream();
                using (XmlDictionaryWriter w = XmlDictionaryWriter.CreateBinaryWriter(_effectData))
                    ds.WriteObject(w, effect.ModuleData);
            }
            public TimeSpan StartTime { get; set; }
            public TimeSpan Duration { get; set; }
            public Guid TypeId { get; private set; }

            public IModuleDataModel GetEffectData()
            {
                DataContractSerializer ds = new DataContractSerializer(_moduleDataClass);
                MemoryStream effectDataIn = new MemoryStream(_effectData.ToArray());
                using (XmlDictionaryReader r = XmlDictionaryReader.CreateBinaryReader(effectDataIn, XmlDictionaryReaderQuotas.Max))
                    return (IModuleDataModel) ds.ReadObject(r);
            }
    }
}




    //    public class EffectModelCandidate
    //    {
    //        private readonly Type _moduleDataClass;
    //        private readonly MemoryStream _effectData;

    //        public EffectModelCandidate(IEffectModuleInstance effect)
    //        {
    //            _moduleDataClass = effect.Descriptor.ModuleDataClass;
    //            DataContractSerializer ds = new DataContractSerializer(_moduleDataClass);

    //            TypeId = effect.Descriptor.TypeId;
    //            _effectData = new MemoryStream();
    //            using (XmlDictionaryWriter w = XmlDictionaryWriter.CreateBinaryWriter(_effectData))
    //                ds.WriteObject(w, effect.ModuleData);
    //        }

          
    //    }
    //}