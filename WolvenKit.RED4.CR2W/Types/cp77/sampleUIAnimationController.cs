using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIAnimationController : inkWidgetLogicController
	{
		private CHandle<inkanimDefinition> _rotation_anim;
		private CHandle<inkanimDefinition> _size_anim;
		private CHandle<inkanimDefinition> _color_anim;
		private CHandle<inkanimDefinition> _alpha_anim;
		private CHandle<inkanimProxy> _rotation_anim_proxy;
		private CHandle<inkanimProxy> _size_anim_proxy;
		private CHandle<inkanimProxy> _color_anim_proxy;
		private CHandle<inkanimProxy> _alpha_anim_proxy;
		private wCHandle<inkWidget> _rotation_widget;
		private wCHandle<inkWidget> _size_widget;
		private wCHandle<inkWidget> _color_widget;
		private wCHandle<inkWidget> _alpha_widget;
		private CUInt32 _iteration_counter;
		private CBool _is_paused;
		private CBool _is_stoped;
		private CBool _playReversed;

		[Ordinal(1)] 
		[RED("rotation_anim")] 
		public CHandle<inkanimDefinition> Rotation_anim
		{
			get
			{
				if (_rotation_anim == null)
				{
					_rotation_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "rotation_anim", cr2w, this);
				}
				return _rotation_anim;
			}
			set
			{
				if (_rotation_anim == value)
				{
					return;
				}
				_rotation_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("size_anim")] 
		public CHandle<inkanimDefinition> Size_anim
		{
			get
			{
				if (_size_anim == null)
				{
					_size_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "size_anim", cr2w, this);
				}
				return _size_anim;
			}
			set
			{
				if (_size_anim == value)
				{
					return;
				}
				_size_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("color_anim")] 
		public CHandle<inkanimDefinition> Color_anim
		{
			get
			{
				if (_color_anim == null)
				{
					_color_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "color_anim", cr2w, this);
				}
				return _color_anim;
			}
			set
			{
				if (_color_anim == value)
				{
					return;
				}
				_color_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("alpha_anim")] 
		public CHandle<inkanimDefinition> Alpha_anim
		{
			get
			{
				if (_alpha_anim == null)
				{
					_alpha_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_anim", cr2w, this);
				}
				return _alpha_anim;
			}
			set
			{
				if (_alpha_anim == value)
				{
					return;
				}
				_alpha_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rotation_anim_proxy")] 
		public CHandle<inkanimProxy> Rotation_anim_proxy
		{
			get
			{
				if (_rotation_anim_proxy == null)
				{
					_rotation_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "rotation_anim_proxy", cr2w, this);
				}
				return _rotation_anim_proxy;
			}
			set
			{
				if (_rotation_anim_proxy == value)
				{
					return;
				}
				_rotation_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("size_anim_proxy")] 
		public CHandle<inkanimProxy> Size_anim_proxy
		{
			get
			{
				if (_size_anim_proxy == null)
				{
					_size_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "size_anim_proxy", cr2w, this);
				}
				return _size_anim_proxy;
			}
			set
			{
				if (_size_anim_proxy == value)
				{
					return;
				}
				_size_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("color_anim_proxy")] 
		public CHandle<inkanimProxy> Color_anim_proxy
		{
			get
			{
				if (_color_anim_proxy == null)
				{
					_color_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "color_anim_proxy", cr2w, this);
				}
				return _color_anim_proxy;
			}
			set
			{
				if (_color_anim_proxy == value)
				{
					return;
				}
				_color_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("alpha_anim_proxy")] 
		public CHandle<inkanimProxy> Alpha_anim_proxy
		{
			get
			{
				if (_alpha_anim_proxy == null)
				{
					_alpha_anim_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "alpha_anim_proxy", cr2w, this);
				}
				return _alpha_anim_proxy;
			}
			set
			{
				if (_alpha_anim_proxy == value)
				{
					return;
				}
				_alpha_anim_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rotation_widget")] 
		public wCHandle<inkWidget> Rotation_widget
		{
			get
			{
				if (_rotation_widget == null)
				{
					_rotation_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rotation_widget", cr2w, this);
				}
				return _rotation_widget;
			}
			set
			{
				if (_rotation_widget == value)
				{
					return;
				}
				_rotation_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("size_widget")] 
		public wCHandle<inkWidget> Size_widget
		{
			get
			{
				if (_size_widget == null)
				{
					_size_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "size_widget", cr2w, this);
				}
				return _size_widget;
			}
			set
			{
				if (_size_widget == value)
				{
					return;
				}
				_size_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("color_widget")] 
		public wCHandle<inkWidget> Color_widget
		{
			get
			{
				if (_color_widget == null)
				{
					_color_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "color_widget", cr2w, this);
				}
				return _color_widget;
			}
			set
			{
				if (_color_widget == value)
				{
					return;
				}
				_color_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("alpha_widget")] 
		public wCHandle<inkWidget> Alpha_widget
		{
			get
			{
				if (_alpha_widget == null)
				{
					_alpha_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "alpha_widget", cr2w, this);
				}
				return _alpha_widget;
			}
			set
			{
				if (_alpha_widget == value)
				{
					return;
				}
				_alpha_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("iteration_counter")] 
		public CUInt32 Iteration_counter
		{
			get
			{
				if (_iteration_counter == null)
				{
					_iteration_counter = (CUInt32) CR2WTypeManager.Create("Uint32", "iteration_counter", cr2w, this);
				}
				return _iteration_counter;
			}
			set
			{
				if (_iteration_counter == value)
				{
					return;
				}
				_iteration_counter = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("is_paused")] 
		public CBool Is_paused
		{
			get
			{
				if (_is_paused == null)
				{
					_is_paused = (CBool) CR2WTypeManager.Create("Bool", "is_paused", cr2w, this);
				}
				return _is_paused;
			}
			set
			{
				if (_is_paused == value)
				{
					return;
				}
				_is_paused = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("is_stoped")] 
		public CBool Is_stoped
		{
			get
			{
				if (_is_stoped == null)
				{
					_is_stoped = (CBool) CR2WTypeManager.Create("Bool", "is_stoped", cr2w, this);
				}
				return _is_stoped;
			}
			set
			{
				if (_is_stoped == value)
				{
					return;
				}
				_is_stoped = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get
			{
				if (_playReversed == null)
				{
					_playReversed = (CBool) CR2WTypeManager.Create("Bool", "playReversed", cr2w, this);
				}
				return _playReversed;
			}
			set
			{
				if (_playReversed == value)
				{
					return;
				}
				_playReversed = value;
				PropertySet(this);
			}
		}

		public sampleUIAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
