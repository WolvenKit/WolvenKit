using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsGeometryKey : CVariable
	{
		private CUInt8 _pe;
		private CArrayFixedSize<CUInt8> _ta;

		[Ordinal(0)] 
		[RED("pe")] 
		public CUInt8 Pe
		{
			get => GetProperty(ref _pe);
			set => SetProperty(ref _pe, value);
		}

		[Ordinal(1)] 
		[RED("ta", 12)] 
		public CArrayFixedSize<CUInt8> Ta
		{
			get => GetProperty(ref _ta);
			set => SetProperty(ref _ta, value);
		}

		public physicsGeometryKey(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
