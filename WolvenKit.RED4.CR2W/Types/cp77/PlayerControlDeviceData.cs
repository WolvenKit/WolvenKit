using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerControlDeviceData : CVariable
	{
		private CFloat _currentYawModifier;
		private CFloat _currentPitchModifier;

		[Ordinal(0)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get
			{
				if (_currentYawModifier == null)
				{
					_currentYawModifier = (CFloat) CR2WTypeManager.Create("Float", "currentYawModifier", cr2w, this);
				}
				return _currentYawModifier;
			}
			set
			{
				if (_currentYawModifier == value)
				{
					return;
				}
				_currentYawModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get
			{
				if (_currentPitchModifier == null)
				{
					_currentPitchModifier = (CFloat) CR2WTypeManager.Create("Float", "currentPitchModifier", cr2w, this);
				}
				return _currentPitchModifier;
			}
			set
			{
				if (_currentPitchModifier == value)
				{
					return;
				}
				_currentPitchModifier = value;
				PropertySet(this);
			}
		}

		public PlayerControlDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
