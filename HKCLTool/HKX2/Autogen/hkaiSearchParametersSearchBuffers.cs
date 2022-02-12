using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public partial class hkaiSearchParametersSearchBuffers : IHavokObject
    {
        public virtual uint Signature { get => 1281450916; }
        
        
        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUInt64();
            br.ReadUInt64();
        }
        
        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
        }
    }
}
