using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkContainerNavigationController : inkDiscreteNavigationController
	{
		private CArray<inkNavigationOverrideEntry> _overrideEntries;
		private CBool _useGlobalInput;

		[Ordinal(4)] 
		[RED("overrideEntries")] 
		public CArray<inkNavigationOverrideEntry> OverrideEntries
		{
			get
			{
				if (_overrideEntries == null)
				{
					_overrideEntries = (CArray<inkNavigationOverrideEntry>) CR2WTypeManager.Create("array:inkNavigationOverrideEntry", "overrideEntries", cr2w, this);
				}
				return _overrideEntries;
			}
			set
			{
				if (_overrideEntries == value)
				{
					return;
				}
				_overrideEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useGlobalInput")] 
		public CBool UseGlobalInput
		{
			get
			{
				if (_useGlobalInput == null)
				{
					_useGlobalInput = (CBool) CR2WTypeManager.Create("Bool", "useGlobalInput", cr2w, this);
				}
				return _useGlobalInput;
			}
			set
			{
				if (_useGlobalInput == value)
				{
					return;
				}
				_useGlobalInput = value;
				PropertySet(this);
			}
		}

		public inkContainerNavigationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
