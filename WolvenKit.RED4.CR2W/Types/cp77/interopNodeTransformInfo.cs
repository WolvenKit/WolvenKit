using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopNodeTransformInfo : CVariable
	{
		private interopStringWithID _id;
		private interopTransformInfo _transformInfo;

		[Ordinal(0)] 
		[RED("id")] 
		public interopStringWithID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (interopStringWithID) CR2WTypeManager.Create("interopStringWithID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transformInfo")] 
		public interopTransformInfo TransformInfo
		{
			get
			{
				if (_transformInfo == null)
				{
					_transformInfo = (interopTransformInfo) CR2WTypeManager.Create("interopTransformInfo", "transformInfo", cr2w, this);
				}
				return _transformInfo;
			}
			set
			{
				if (_transformInfo == value)
				{
					return;
				}
				_transformInfo = value;
				PropertySet(this);
			}
		}

		public interopNodeTransformInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
