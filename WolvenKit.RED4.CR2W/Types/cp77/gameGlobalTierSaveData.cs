using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGlobalTierSaveData : CVariable
	{
		private CEnum<gameGlobalTierSubtype> _subtype;
		private CHandle<gameSceneTierData> _data;

		[Ordinal(0)] 
		[RED("subtype")] 
		public CEnum<gameGlobalTierSubtype> Subtype
		{
			get => GetProperty(ref _subtype);
			set => SetProperty(ref _subtype, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameSceneTierData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public gameGlobalTierSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
