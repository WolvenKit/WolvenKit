using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocomotionAirEvents : LocomotionEventsTransition
	{
		private CBool _maxSuperheroFallHeight;
		private CBool _updateInputToggles;

		[Ordinal(0)] 
		[RED("maxSuperheroFallHeight")] 
		public CBool MaxSuperheroFallHeight
		{
			get
			{
				if (_maxSuperheroFallHeight == null)
				{
					_maxSuperheroFallHeight = (CBool) CR2WTypeManager.Create("Bool", "maxSuperheroFallHeight", cr2w, this);
				}
				return _maxSuperheroFallHeight;
			}
			set
			{
				if (_maxSuperheroFallHeight == value)
				{
					return;
				}
				_maxSuperheroFallHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("updateInputToggles")] 
		public CBool UpdateInputToggles
		{
			get
			{
				if (_updateInputToggles == null)
				{
					_updateInputToggles = (CBool) CR2WTypeManager.Create("Bool", "updateInputToggles", cr2w, this);
				}
				return _updateInputToggles;
			}
			set
			{
				if (_updateInputToggles == value)
				{
					return;
				}
				_updateInputToggles = value;
				PropertySet(this);
			}
		}

		public LocomotionAirEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
