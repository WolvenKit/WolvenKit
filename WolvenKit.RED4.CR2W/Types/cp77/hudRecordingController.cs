using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudRecordingController : gameuiHUDGameController
	{
		private wCHandle<inkCompoundWidget> _root;
		private CHandle<inkanimProxy> _anim_intro;
		private CHandle<inkanimProxy> _anim_outro;
		private CHandle<inkanimProxy> _anim_loop;
		private inkanimPlaybackOptions _option_intro;
		private inkanimPlaybackOptions _option_loop;
		private inkanimPlaybackOptions _option_outro;
		private CUInt32 _factListener;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
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

		[Ordinal(10)] 
		[RED("anim_intro")] 
		public CHandle<inkanimProxy> Anim_intro
		{
			get
			{
				if (_anim_intro == null)
				{
					_anim_intro = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_intro", cr2w, this);
				}
				return _anim_intro;
			}
			set
			{
				if (_anim_intro == value)
				{
					return;
				}
				_anim_intro = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("anim_outro")] 
		public CHandle<inkanimProxy> Anim_outro
		{
			get
			{
				if (_anim_outro == null)
				{
					_anim_outro = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_outro", cr2w, this);
				}
				return _anim_outro;
			}
			set
			{
				if (_anim_outro == value)
				{
					return;
				}
				_anim_outro = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("anim_loop")] 
		public CHandle<inkanimProxy> Anim_loop
		{
			get
			{
				if (_anim_loop == null)
				{
					_anim_loop = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim_loop", cr2w, this);
				}
				return _anim_loop;
			}
			set
			{
				if (_anim_loop == value)
				{
					return;
				}
				_anim_loop = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("option_intro")] 
		public inkanimPlaybackOptions Option_intro
		{
			get
			{
				if (_option_intro == null)
				{
					_option_intro = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "option_intro", cr2w, this);
				}
				return _option_intro;
			}
			set
			{
				if (_option_intro == value)
				{
					return;
				}
				_option_intro = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("option_loop")] 
		public inkanimPlaybackOptions Option_loop
		{
			get
			{
				if (_option_loop == null)
				{
					_option_loop = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "option_loop", cr2w, this);
				}
				return _option_loop;
			}
			set
			{
				if (_option_loop == value)
				{
					return;
				}
				_option_loop = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("option_outro")] 
		public inkanimPlaybackOptions Option_outro
		{
			get
			{
				if (_option_outro == null)
				{
					_option_outro = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "option_outro", cr2w, this);
				}
				return _option_outro;
			}
			set
			{
				if (_option_outro == value)
				{
					return;
				}
				_option_outro = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("factListener")] 
		public CUInt32 FactListener
		{
			get
			{
				if (_factListener == null)
				{
					_factListener = (CUInt32) CR2WTypeManager.Create("Uint32", "factListener", cr2w, this);
				}
				return _factListener;
			}
			set
			{
				if (_factListener == value)
				{
					return;
				}
				_factListener = value;
				PropertySet(this);
			}
		}

		public hudRecordingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
