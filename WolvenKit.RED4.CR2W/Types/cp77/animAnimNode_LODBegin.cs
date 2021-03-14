using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LODBegin : animAnimNode_OnePoseInput
	{
		private CUInt32 _levelOfDetail;

		[Ordinal(12)] 
		[RED("levelOfDetail")] 
		public CUInt32 LevelOfDetail
		{
			get
			{
				if (_levelOfDetail == null)
				{
					_levelOfDetail = (CUInt32) CR2WTypeManager.Create("Uint32", "levelOfDetail", cr2w, this);
				}
				return _levelOfDetail;
			}
			set
			{
				if (_levelOfDetail == value)
				{
					return;
				}
				_levelOfDetail = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LODBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
