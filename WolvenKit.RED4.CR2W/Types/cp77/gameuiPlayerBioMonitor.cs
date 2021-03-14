using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPlayerBioMonitor : CVariable
	{
		private CInt32 _currentHealth;
		private CInt32 _maximumHealth;
		private CInt32 _currentCyberwarePct;
		private CInt32 _currentArmor;
		private CInt32 _maximumArmor;

		[Ordinal(0)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (CInt32) CR2WTypeManager.Create("Int32", "currentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get
			{
				if (_maximumHealth == null)
				{
					_maximumHealth = (CInt32) CR2WTypeManager.Create("Int32", "maximumHealth", cr2w, this);
				}
				return _maximumHealth;
			}
			set
			{
				if (_maximumHealth == value)
				{
					return;
				}
				_maximumHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentCyberwarePct")] 
		public CInt32 CurrentCyberwarePct
		{
			get
			{
				if (_currentCyberwarePct == null)
				{
					_currentCyberwarePct = (CInt32) CR2WTypeManager.Create("Int32", "currentCyberwarePct", cr2w, this);
				}
				return _currentCyberwarePct;
			}
			set
			{
				if (_currentCyberwarePct == value)
				{
					return;
				}
				_currentCyberwarePct = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentArmor")] 
		public CInt32 CurrentArmor
		{
			get
			{
				if (_currentArmor == null)
				{
					_currentArmor = (CInt32) CR2WTypeManager.Create("Int32", "currentArmor", cr2w, this);
				}
				return _currentArmor;
			}
			set
			{
				if (_currentArmor == value)
				{
					return;
				}
				_currentArmor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maximumArmor")] 
		public CInt32 MaximumArmor
		{
			get
			{
				if (_maximumArmor == null)
				{
					_maximumArmor = (CInt32) CR2WTypeManager.Create("Int32", "maximumArmor", cr2w, this);
				}
				return _maximumArmor;
			}
			set
			{
				if (_maximumArmor == value)
				{
					return;
				}
				_maximumArmor = value;
				PropertySet(this);
			}
		}

		public gameuiPlayerBioMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
