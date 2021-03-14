using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentExplosionEvent : redEvent
	{
		private Vector4 _epicentrum;
		private CFloat _strength;

		[Ordinal(0)] 
		[RED("epicentrum")] 
		public Vector4 Epicentrum
		{
			get
			{
				if (_epicentrum == null)
				{
					_epicentrum = (Vector4) CR2WTypeManager.Create("Vector4", "epicentrum", cr2w, this);
				}
				return _epicentrum;
			}
			set
			{
				if (_epicentrum == value)
				{
					return;
				}
				_epicentrum = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (CFloat) CR2WTypeManager.Create("Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		public DismembermentExplosionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
