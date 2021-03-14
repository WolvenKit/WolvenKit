using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entColliderComponentShape : ISerializable
	{
		private Transform _localToBody;

		[Ordinal(0)] 
		[RED("localToBody")] 
		public Transform LocalToBody
		{
			get
			{
				if (_localToBody == null)
				{
					_localToBody = (Transform) CR2WTypeManager.Create("Transform", "localToBody", cr2w, this);
				}
				return _localToBody;
			}
			set
			{
				if (_localToBody == value)
				{
					return;
				}
				_localToBody = value;
				PropertySet(this);
			}
		}

		public entColliderComponentShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
