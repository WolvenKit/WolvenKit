using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimDatabaseCollectionEntry : CVariable
	{
		private CName _name;
		private rRef<C2dArray> _animDatabase;
		private rRef<animGenericAnimDatabase> _overrideAnimDatabase;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("animDatabase")] 
		public rRef<C2dArray> AnimDatabase
		{
			get => GetProperty(ref _animDatabase);
			set => SetProperty(ref _animDatabase, value);
		}

		[Ordinal(2)] 
		[RED("overrideAnimDatabase")] 
		public rRef<animGenericAnimDatabase> OverrideAnimDatabase
		{
			get => GetProperty(ref _overrideAnimDatabase);
			set => SetProperty(ref _overrideAnimDatabase, value);
		}

		public animAnimDatabaseCollectionEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
