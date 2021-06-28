using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animTEMP_IKTargetsControllerBodyType : CVariable
	{
		private CName _genderTag;
		private CName _bodyTypeTag;
		private CArray<animIKChainSettings> _ikChainSettings;

		[Ordinal(0)] 
		[RED("genderTag")] 
		public CName GenderTag
		{
			get => GetProperty(ref _genderTag);
			set => SetProperty(ref _genderTag, value);
		}

		[Ordinal(1)] 
		[RED("bodyTypeTag")] 
		public CName BodyTypeTag
		{
			get => GetProperty(ref _bodyTypeTag);
			set => SetProperty(ref _bodyTypeTag, value);
		}

		[Ordinal(2)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get => GetProperty(ref _ikChainSettings);
			set => SetProperty(ref _ikChainSettings, value);
		}

		public animTEMP_IKTargetsControllerBodyType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
