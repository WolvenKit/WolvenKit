using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerHealth : ScannerChunk
	{
		private CInt32 _currentHealth;
		private CInt32 _totalHealth;

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
		[RED("totalHealth")] 
		public CInt32 TotalHealth
		{
			get
			{
				if (_totalHealth == null)
				{
					_totalHealth = (CInt32) CR2WTypeManager.Create("Int32", "totalHealth", cr2w, this);
				}
				return _totalHealth;
			}
			set
			{
				if (_totalHealth == value)
				{
					return;
				}
				_totalHealth = value;
				PropertySet(this);
			}
		}

		public ScannerHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
