using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionMappinController : gameuiInteractionMappinController
	{
		private wCHandle<gamemappinsInteractionMappin> _mappin;
		private wCHandle<inkWidget> _root;
		private CBool _isConnected;

		[Ordinal(11)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsInteractionMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(13)] 
		[RED("isConnected")] 
		public CBool IsConnected
		{
			get => GetProperty(ref _isConnected);
			set => SetProperty(ref _isConnected, value);
		}

		public InteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
