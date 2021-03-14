using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsControllerHit : CVariable
	{
		private Vector4 _worldPos;
		private Vector4 _worldNormal;

		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector4 WorldPos
		{
			get
			{
				if (_worldPos == null)
				{
					_worldPos = (Vector4) CR2WTypeManager.Create("Vector4", "worldPos", cr2w, this);
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

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get
			{
				if (_worldNormal == null)
				{
					_worldNormal = (Vector4) CR2WTypeManager.Create("Vector4", "worldNormal", cr2w, this);
				}
				return _worldNormal;
			}
			set
			{
				if (_worldNormal == value)
				{
					return;
				}
				_worldNormal = value;
				PropertySet(this);
			}
		}

		public physicsControllerHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
