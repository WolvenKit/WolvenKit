using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapGameObject : gameObject
	{
		private CArray<gameuiDistrictTriggerData> _districts;

		[Ordinal(40)] 
		[RED("districts")] 
		public CArray<gameuiDistrictTriggerData> Districts
		{
			get => GetProperty(ref _districts);
			set => SetProperty(ref _districts, value);
		}

		public gameuiWorldMapGameObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
