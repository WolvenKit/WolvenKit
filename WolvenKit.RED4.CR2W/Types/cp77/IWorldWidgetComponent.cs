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
			get => GetProperty(ref _glitchValue);
			set => SetProperty(ref _glitchValue, value);
		}

		[Ordinal(6)] 
		[RED("tintColor")] 
		public CColor TintColor
		{
			get => GetProperty(ref _tintColor);
			set => SetProperty(ref _tintColor, value);
		}

		[Ordinal(7)] 
		[RED("screenAreaMultiplier")] 
		public CFloat ScreenAreaMultiplier
		{
			get => GetProperty(ref _screenAreaMultiplier);
			set => SetProperty(ref _screenAreaMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<worlduiMeshTargetBinding> MeshTargetBinding
		{
			get => GetProperty(ref _meshTargetBinding);
			set => SetProperty(ref _meshTargetBinding, value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public IWorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
