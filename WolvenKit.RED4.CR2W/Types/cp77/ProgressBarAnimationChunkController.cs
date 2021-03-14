using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarAnimationChunkController : inkWidgetLogicController
	{
		private inkWidgetReference _rootCanvas;
		private inkWidgetReference _barCanvas;
		private CHandle<inkanimProxy> _hitAnim;
		private CFloat _fullbarSize;
		private CBool _isNegative;

		[Ordinal(1)] 
		[RED("rootCanvas")] 
		public inkWidgetReference RootCanvas
		{
			get
			{
				if (_rootCanvas == null)
				{
					_rootCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rootCanvas", cr2w, this);
				}
				return _rootCanvas;
			}
			set
			{
				if (_rootCanvas == value)
				{
					return;
				}
				_rootCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("barCanvas")] 
		public inkWidgetReference BarCanvas
		{
			get
			{
				if (_barCanvas == null)
				{
					_barCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "barCanvas", cr2w, this);
				}
				return _barCanvas;
			}
			set
			{
				if (_barCanvas == value)
				{
					return;
				}
				_barCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitAnim")] 
		public CHandle<inkanimProxy> HitAnim
		{
			get
			{
				if (_hitAnim == null)
				{
					_hitAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hitAnim", cr2w, this);
				}
				return _hitAnim;
			}
			set
			{
				if (_hitAnim == value)
				{
					return;
				}
				_hitAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fullbarSize")] 
		public CFloat FullbarSize
		{
			get
			{
				if (_fullbarSize == null)
				{
					_fullbarSize = (CFloat) CR2WTypeManager.Create("Float", "fullbarSize", cr2w, this);
				}
				return _fullbarSize;
			}
			set
			{
				if (_fullbarSize == value)
				{
					return;
				}
				_fullbarSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isNegative")] 
		public CBool IsNegative
		{
			get
			{
				if (_isNegative == null)
				{
					_isNegative = (CBool) CR2WTypeManager.Create("Bool", "isNegative", cr2w, this);
				}
				return _isNegative;
			}
			set
			{
				if (_isNegative == value)
				{
					return;
				}
				_isNegative = value;
				PropertySet(this);
			}
		}

		public ProgressBarAnimationChunkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
