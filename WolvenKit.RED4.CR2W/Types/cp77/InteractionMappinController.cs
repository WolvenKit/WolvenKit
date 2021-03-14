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
			get
			{
				if (_mappin == null)
				{
					_mappin = (wCHandle<gamemappinsInteractionMappin>) CR2WTypeManager.Create("whandle:gamemappinsInteractionMappin", "mappin", cr2w, this);
				}
				return _mappin;
			}
			set
			{
				if (_mappin == value)
				{
					return;
				}
				_mappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isConnected")] 
		public CBool IsConnected
		{
			get
			{
				if (_isConnected == null)
				{
					_isConnected = (CBool) CR2WTypeManager.Create("Bool", "isConnected", cr2w, this);
				}
				return _isConnected;
			}
			set
			{
				if (_isConnected == value)
				{
					return;
				}
				_isConnected = value;
				PropertySet(this);
			}
		}

		public InteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
