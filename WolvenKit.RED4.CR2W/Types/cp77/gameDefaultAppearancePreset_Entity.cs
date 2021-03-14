using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDefaultAppearancePreset_Entity : ISerializable
	{
		private CUInt64 _entityPathHash;
		private CName _debugEntityPath;
		private CName _defaultAppearanceName;

		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get
			{
				if (_entityPathHash == null)
				{
					_entityPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "entityPathHash", cr2w, this);
				}
				return _entityPathHash;
			}
			set
			{
				if (_entityPathHash == value)
				{
					return;
				}
				_entityPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CName DebugEntityPath
		{
			get
			{
				if (_debugEntityPath == null)
				{
					_debugEntityPath = (CName) CR2WTypeManager.Create("CName", "debugEntityPath", cr2w, this);
				}
				return _debugEntityPath;
			}
			set
			{
				if (_debugEntityPath == value)
				{
					return;
				}
				_debugEntityPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultAppearanceName")] 
		public CName DefaultAppearanceName
		{
			get
			{
				if (_defaultAppearanceName == null)
				{
					_defaultAppearanceName = (CName) CR2WTypeManager.Create("CName", "defaultAppearanceName", cr2w, this);
				}
				return _defaultAppearanceName;
			}
			set
			{
				if (_defaultAppearanceName == value)
				{
					return;
				}
				_defaultAppearanceName = value;
				PropertySet(this);
			}
		}

		public gameDefaultAppearancePreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
