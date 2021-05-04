using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCyberware : CVariable
	{
		private CString _cyberwareName;
		private CInt32 _cyberWareTier;
		private CString _loc_name_key;
		private CString _loc_desc_key;

		[Ordinal(0)] 
		[RED("cyberwareName")] 
		public CString CyberwareName
		{
			get => GetProperty(ref _cyberwareName);
			set => SetProperty(ref _cyberwareName, value);
		}

		[Ordinal(1)] 
		[RED("cyberWareTier")] 
		public CInt32 CyberWareTier
		{
			get => GetProperty(ref _cyberWareTier);
			set => SetProperty(ref _cyberWareTier, value);
		}

		[Ordinal(2)] 
		[RED("loc_name_key")] 
		public CString Loc_name_key
		{
			get => GetProperty(ref _loc_name_key);
			set => SetProperty(ref _loc_name_key, value);
		}

		[Ordinal(3)] 
		[RED("loc_desc_key")] 
		public CString Loc_desc_key
		{
			get => GetProperty(ref _loc_desc_key);
			set => SetProperty(ref _loc_desc_key, value);
		}

		public SCyberware(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
