using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotData : ISerializable
	{
		private scnSceneWorkspotDataId _dataId;

		[Ordinal(0)] 
		[RED("dataId")] 
		public scnSceneWorkspotDataId DataId
		{
			get => GetProperty(ref _dataId);
			set => SetProperty(ref _dataId, value);
		}

		public scnWorkspotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
