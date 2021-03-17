using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeQuickhackKillEntry : CVariable
	{
		private wCHandle<gameObject> _source;
		private CArray<wCHandle<gameObject>> _targets;
		private CArray<CFloat> _timestamps;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("targets")] 
		public CArray<wCHandle<gameObject>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(2)] 
		[RED("timestamps")] 
		public CArray<CFloat> Timestamps
		{
			get => GetProperty(ref _timestamps);
			set => SetProperty(ref _timestamps, value);
		}

		public GrenadeQuickhackKillEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
