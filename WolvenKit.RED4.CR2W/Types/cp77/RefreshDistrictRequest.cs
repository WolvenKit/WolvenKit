using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshDistrictRequest : gameScriptableSystemRequest
	{
		private wCHandle<gamedataDistrictPreventionData_Record> _preventionPreset;

		[Ordinal(0)] 
		[RED("preventionPreset")] 
		public wCHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetProperty(ref _preventionPreset);
			set => SetProperty(ref _preventionPreset, value);
		}

		public RefreshDistrictRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
