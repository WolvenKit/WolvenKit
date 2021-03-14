using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReflectorSFX : VendingMachineSFX
	{
		private CName _distraction;
		private CName _turnOn;
		private CName _turnOff;

		[Ordinal(2)] 
		[RED("distraction")] 
		public CName Distraction
		{
			get
			{
				if (_distraction == null)
				{
					_distraction = (CName) CR2WTypeManager.Create("CName", "distraction", cr2w, this);
				}
				return _distraction;
			}
			set
			{
				if (_distraction == value)
				{
					return;
				}
				_distraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("turnOn")] 
		public CName TurnOn
		{
			get
			{
				if (_turnOn == null)
				{
					_turnOn = (CName) CR2WTypeManager.Create("CName", "turnOn", cr2w, this);
				}
				return _turnOn;
			}
			set
			{
				if (_turnOn == value)
				{
					return;
				}
				_turnOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("turnOff")] 
		public CName TurnOff
		{
			get
			{
				if (_turnOff == null)
				{
					_turnOff = (CName) CR2WTypeManager.Create("CName", "turnOff", cr2w, this);
				}
				return _turnOff;
			}
			set
			{
				if (_turnOff == value)
				{
					return;
				}
				_turnOff = value;
				PropertySet(this);
			}
		}

		public ReflectorSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
