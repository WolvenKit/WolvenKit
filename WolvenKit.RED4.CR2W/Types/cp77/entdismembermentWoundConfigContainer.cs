using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundConfigContainer : ISerializable
	{
		private CName _appearanceName;
		private CArray<entdismembermentWoundConfig> _wounds;

		[Ordinal(0)] 
		[RED("AppearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(1)] 
		[RED("Wounds")] 
		public CArray<entdismembermentWoundConfig> Wounds
		{
			get => GetProperty(ref _wounds);
			set => SetProperty(ref _wounds, value);
		}

		public entdismembermentWoundConfigContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
