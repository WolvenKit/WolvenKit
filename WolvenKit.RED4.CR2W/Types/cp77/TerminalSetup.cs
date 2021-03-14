using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalSetup : CVariable
	{
		private CInt32 _minClearance;
		private CInt32 _maxClearance;
		private CBool _ignoreSlaveAuthorizationModule;
		private CBool _shouldForceVirtualSystem;

		[Ordinal(0)] 
		[RED("minClearance")] 
		public CInt32 MinClearance
		{
			get
			{
				if (_minClearance == null)
				{
					_minClearance = (CInt32) CR2WTypeManager.Create("Int32", "minClearance", cr2w, this);
				}
				return _minClearance;
			}
			set
			{
				if (_minClearance == value)
				{
					return;
				}
				_minClearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxClearance")] 
		public CInt32 MaxClearance
		{
			get
			{
				if (_maxClearance == null)
				{
					_maxClearance = (CInt32) CR2WTypeManager.Create("Int32", "maxClearance", cr2w, this);
				}
				return _maxClearance;
			}
			set
			{
				if (_maxClearance == value)
				{
					return;
				}
				_maxClearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ignoreSlaveAuthorizationModule")] 
		public CBool IgnoreSlaveAuthorizationModule
		{
			get
			{
				if (_ignoreSlaveAuthorizationModule == null)
				{
					_ignoreSlaveAuthorizationModule = (CBool) CR2WTypeManager.Create("Bool", "ignoreSlaveAuthorizationModule", cr2w, this);
				}
				return _ignoreSlaveAuthorizationModule;
			}
			set
			{
				if (_ignoreSlaveAuthorizationModule == value)
				{
					return;
				}
				_ignoreSlaveAuthorizationModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("shouldForceVirtualSystem")] 
		public CBool ShouldForceVirtualSystem
		{
			get
			{
				if (_shouldForceVirtualSystem == null)
				{
					_shouldForceVirtualSystem = (CBool) CR2WTypeManager.Create("Bool", "shouldForceVirtualSystem", cr2w, this);
				}
				return _shouldForceVirtualSystem;
			}
			set
			{
				if (_shouldForceVirtualSystem == value)
				{
					return;
				}
				_shouldForceVirtualSystem = value;
				PropertySet(this);
			}
		}

		public TerminalSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
