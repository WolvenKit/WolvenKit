using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinUIProfile : CVariable
	{
		private redResourceReferenceScriptToken _widgetResource;
		private CName _widgetLibraryID;
		private CHandle<gamedataMappinUISpawnProfile_Record> _spawn;
		private CHandle<gamedataMappinUIRuntimeProfile_Record> _runtime;

		[Ordinal(0)] 
		[RED("widgetResource")] 
		public redResourceReferenceScriptToken WidgetResource
		{
			get
			{
				if (_widgetResource == null)
				{
					_widgetResource = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "widgetResource", cr2w, this);
				}
				return _widgetResource;
			}
			set
			{
				if (_widgetResource == value)
				{
					return;
				}
				_widgetResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("widgetLibraryID")] 
		public CName WidgetLibraryID
		{
			get
			{
				if (_widgetLibraryID == null)
				{
					_widgetLibraryID = (CName) CR2WTypeManager.Create("CName", "widgetLibraryID", cr2w, this);
				}
				return _widgetLibraryID;
			}
			set
			{
				if (_widgetLibraryID == value)
				{
					return;
				}
				_widgetLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawn")] 
		public CHandle<gamedataMappinUISpawnProfile_Record> Spawn
		{
			get
			{
				if (_spawn == null)
				{
					_spawn = (CHandle<gamedataMappinUISpawnProfile_Record>) CR2WTypeManager.Create("handle:gamedataMappinUISpawnProfile_Record", "spawn", cr2w, this);
				}
				return _spawn;
			}
			set
			{
				if (_spawn == value)
				{
					return;
				}
				_spawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("runtime")] 
		public CHandle<gamedataMappinUIRuntimeProfile_Record> Runtime
		{
			get
			{
				if (_runtime == null)
				{
					_runtime = (CHandle<gamedataMappinUIRuntimeProfile_Record>) CR2WTypeManager.Create("handle:gamedataMappinUIRuntimeProfile_Record", "runtime", cr2w, this);
				}
				return _runtime;
			}
			set
			{
				if (_runtime == value)
				{
					return;
				}
				_runtime = value;
				PropertySet(this);
			}
		}

		public gameuiMappinUIProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
