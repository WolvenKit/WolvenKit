using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerCreatedEvent : redEvent
	{
		private CInt32 _index;
		private CBool _isTrait;
		private wCHandle<PerkDisplayContainerController> _container;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get => GetProperty(ref _isTrait);
			set => SetProperty(ref _isTrait, value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public wCHandle<PerkDisplayContainerController> Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		public PerkDisplayContainerCreatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
