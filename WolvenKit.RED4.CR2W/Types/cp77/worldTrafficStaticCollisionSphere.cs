using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficStaticCollisionSphere : CVariable
	{
		private Vector3 _worldPos;

		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector3 WorldPos
		{
			get
			{
				if (_worldPos == null)
				{
					_worldPos = (Vector3) CR2WTypeManager.Create("Vector3", "worldPos", cr2w, this);
				}
				return _worldPos;
			}
			set
			{
				if (_worldPos == value)
				{
					return;
				}
				_worldPos = value;
				PropertySet(this);
			}
		}

		public worldTrafficStaticCollisionSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
