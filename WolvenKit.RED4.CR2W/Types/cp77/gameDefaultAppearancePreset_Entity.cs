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
			get => GetProperty(ref _entityPathHash);
			set => SetProperty(ref _entityPathHash, value);
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CName DebugEntityPath
		{
			get => GetProperty(ref _debugEntityPath);
			set => SetProperty(ref _debugEntityPath, value);
		}

		[Ordinal(2)] 
		[RED("defaultAppearanceName")] 
		public CName DefaultAppearanceName
		{
			get => GetProperty(ref _defaultAppearanceName);
			set => SetProperty(ref _defaultAppearanceName, value);
		}

		public gameDefaultAppearancePreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
