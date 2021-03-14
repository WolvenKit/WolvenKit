using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronFullAutoController : AmmoLogicController
	{
		private wCHandle<inkTextWidget> _ammoCountText;
		private wCHandle<inkImageWidget> _ammoBar;

		[Ordinal(3)] 
		[RED("ammoCountText")] 
		public wCHandle<inkTextWidget> AmmoCountText
		{
			get
			{
				if (_ammoCountText == null)
				{
					_ammoCountText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "ammoCountText", cr2w, this);
				}
				return _ammoCountText;
			}
			set
			{
				if (_ammoCountText == value)
				{
					return;
				}
				_ammoCountText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ammoBar")] 
		public wCHandle<inkImageWidget> AmmoBar
		{
			get
			{
				if (_ammoBar == null)
				{
					_ammoBar = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "ammoBar", cr2w, this);
				}
				return _ammoBar;
			}
			set
			{
				if (_ammoBar == value)
				{
					return;
				}
				_ammoBar = value;
				PropertySet(this);
			}
		}

		public megatronFullAutoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
