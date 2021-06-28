using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoyceHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<NPCPuppet> _owner;
		private CHandle<RoyceComponent> _royceComponent;
		private CArray<wCHandle<gameWeakspotObject>> _weakspots;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("royceComponent")] 
		public CHandle<RoyceComponent> RoyceComponent
		{
			get => GetProperty(ref _royceComponent);
			set => SetProperty(ref _royceComponent, value);
		}

		[Ordinal(2)] 
		[RED("weakspots")] 
		public CArray<wCHandle<gameWeakspotObject>> Weakspots
		{
			get => GetProperty(ref _weakspots);
			set => SetProperty(ref _weakspots, value);
		}

		public RoyceHealthChangeListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
