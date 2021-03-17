using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCinematicAnimSetSRRef : CVariable
	{
		private raRef<animAnimSet> _asyncAnimSet;
		private CUInt8 _priority;
		private CBool _isOverride;

		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public raRef<animAnimSet> AsyncAnimSet
		{
			get => GetProperty(ref _asyncAnimSet);
			set => SetProperty(ref _asyncAnimSet, value);
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(2)] 
		[RED("isOverride")] 
		public CBool IsOverride
		{
			get => GetProperty(ref _isOverride);
			set => SetProperty(ref _isOverride, value);
		}

		public scnCinematicAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
