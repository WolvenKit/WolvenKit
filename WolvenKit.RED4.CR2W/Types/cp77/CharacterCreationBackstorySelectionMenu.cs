using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationBackstorySelectionMenu : gameuiBaseCharacterCreationController
	{
		private inkWidgetReference _nomad;
		private inkWidgetReference _streetRat;
		private inkWidgetReference _corpo;
		private CHandle<inkanimProxy> _animationProxy;
		private CString _clickTarget;
		private CString _nomadTarget;
		private CString _streetTarget;
		private CString _corpoTarget;

		[Ordinal(6)] 
		[RED("nomad")] 
		public inkWidgetReference Nomad
		{
			get => GetProperty(ref _nomad);
			set => SetProperty(ref _nomad, value);
		}

		[Ordinal(7)] 
		[RED("streetRat")] 
		public inkWidgetReference StreetRat
		{
			get => GetProperty(ref _streetRat);
			set => SetProperty(ref _streetRat, value);
		}

		[Ordinal(8)] 
		[RED("corpo")] 
		public inkWidgetReference Corpo
		{
			get => GetProperty(ref _corpo);
			set => SetProperty(ref _corpo, value);
		}

		[Ordinal(9)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(10)] 
		[RED("clickTarget")] 
		public CString ClickTarget
		{
			get => GetProperty(ref _clickTarget);
			set => SetProperty(ref _clickTarget, value);
		}

		[Ordinal(11)] 
		[RED("nomadTarget")] 
		public CString NomadTarget
		{
			get => GetProperty(ref _nomadTarget);
			set => SetProperty(ref _nomadTarget, value);
		}

		[Ordinal(12)] 
		[RED("streetTarget")] 
		public CString StreetTarget
		{
			get => GetProperty(ref _streetTarget);
			set => SetProperty(ref _streetTarget, value);
		}

		[Ordinal(13)] 
		[RED("corpoTarget")] 
		public CString CorpoTarget
		{
			get => GetProperty(ref _corpoTarget);
			set => SetProperty(ref _corpoTarget, value);
		}

		public CharacterCreationBackstorySelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
