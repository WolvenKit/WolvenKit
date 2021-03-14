using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IWorldWidgetComponent : WidgetBaseComponent
	{
		private CFloat _glitchValue;
		private CColor _tintColor;
		private CFloat _screenAreaMultiplier;
		private CHandle<worlduiMeshTargetBinding> _meshTargetBinding;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get
			{
				if (_glitchValue == null)
				{
					_glitchValue = (CFloat) CR2WTypeManager.Create("Float", "glitchValue", cr2w, this);
				}
				return _glitchValue;
			}
			set
			{
				if (_glitchValue == value)
				{
					return;
				}
				_glitchValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tintColor")] 
		public CColor TintColor
		{
			get
			{
				if (_tintColor == null)
				{
					_tintColor = (CColor) CR2WTypeManager.Create("Color", "tintColor", cr2w, this);
				}
				return _tintColor;
			}
			set
			{
				if (_tintColor == value)
				{
					return;
				}
				_tintColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("screenAreaMultiplier")] 
		public CFloat ScreenAreaMultiplier
		{
			get
			{
				if (_screenAreaMultiplier == null)
				{
					_screenAreaMultiplier = (CFloat) CR2WTypeManager.Create("Float", "screenAreaMultiplier", cr2w, this);
				}
				return _screenAreaMultiplier;
			}
			set
			{
				if (_screenAreaMultiplier == value)
				{
					return;
				}
				_screenAreaMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get
			{
				if (_meshTargetBinding == null)
				{
					_meshTargetBinding = (CHandle<worlduiMeshTargetBinding>) CR2WTypeManager.Create("handle:worlduiMeshTargetBinding", "meshTargetBinding", cr2w, this);
				}
				return _meshTargetBinding;
			}
			set
			{
				if (_meshTargetBinding == value)
				{
					return;
				}
				_meshTargetBinding = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public IWorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
