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
			get
			{
				if (_dataId == null)
				{
					_dataId = (scnSceneWorkspotDataId) CR2WTypeManager.Create("scnSceneWorkspotDataId", "dataId", cr2w, this);
				}
				return _dataId;
			}
			set
			{
				if (_dataId == value)
				{
					return;
				}
				_dataId = value;
				PropertySet(this);
			}
		}

		public scnWorkspotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
