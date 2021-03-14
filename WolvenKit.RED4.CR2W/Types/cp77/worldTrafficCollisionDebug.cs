using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCollisionDebug : ISerializable
	{
		private CArray<worldDbgOverlapBox> _overlapBoxes;

		[Ordinal(0)] 
		[RED("overlapBoxes")] 
		public CArray<worldDbgOverlapBox> OverlapBoxes
		{
			get
			{
				if (_overlapBoxes == null)
				{
					_overlapBoxes = (CArray<worldDbgOverlapBox>) CR2WTypeManager.Create("array:worldDbgOverlapBox", "overlapBoxes", cr2w, this);
				}
				return _overlapBoxes;
			}
			set
			{
				if (_overlapBoxes == value)
				{
					return;
				}
				_overlapBoxes = value;
				PropertySet(this);
			}
		}

		public worldTrafficCollisionDebug(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
