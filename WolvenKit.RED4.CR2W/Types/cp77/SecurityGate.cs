using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGate : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _sideA;
		private CHandle<gameStaticTriggerAreaComponent> _sideB;
		private CHandle<gameStaticTriggerAreaComponent> _scanningArea;
		private CArray<TrespasserEntry> _trespassersDataList;

		[Ordinal(93)] 
		[RED("sideA")] 
		public CHandle<gameStaticTriggerAreaComponent> SideA
		{
			get
			{
				if (_sideA == null)
				{
					_sideA = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "sideA", cr2w, this);
				}
				return _sideA;
			}
			set
			{
				if (_sideA == value)
				{
					return;
				}
				_sideA = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("sideB")] 
		public CHandle<gameStaticTriggerAreaComponent> SideB
		{
			get
			{
				if (_sideB == null)
				{
					_sideB = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "sideB", cr2w, this);
				}
				return _sideB;
			}
			set
			{
				if (_sideB == value)
				{
					return;
				}
				_sideB = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("scanningArea")] 
		public CHandle<gameStaticTriggerAreaComponent> ScanningArea
		{
			get
			{
				if (_scanningArea == null)
				{
					_scanningArea = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "scanningArea", cr2w, this);
				}
				return _scanningArea;
			}
			set
			{
				if (_scanningArea == value)
				{
					return;
				}
				_scanningArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get
			{
				if (_trespassersDataList == null)
				{
					_trespassersDataList = (CArray<TrespasserEntry>) CR2WTypeManager.Create("array:TrespasserEntry", "trespassersDataList", cr2w, this);
				}
				return _trespassersDataList;
			}
			set
			{
				if (_trespassersDataList == value)
				{
					return;
				}
				_trespassersDataList = value;
				PropertySet(this);
			}
		}

		public SecurityGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
