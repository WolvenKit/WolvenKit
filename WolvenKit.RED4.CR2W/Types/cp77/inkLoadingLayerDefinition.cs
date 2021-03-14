using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLoadingLayerDefinition : inkLayerDefinition
	{
		private raRef<inkWidgetLibraryResource> _splashLoadingScreenResource;
		private raRef<inkWidgetLibraryResource> _initialLoadingScreenResource;
		private raRef<inkWidgetLibraryResource> _fastTravelLoadingScreenResource;
		private raRef<inkWidgetLibraryResource> _fallbackLoadingScreenResource;

		[Ordinal(8)] 
		[RED("splashLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> SplashLoadingScreenResource
		{
			get
			{
				if (_splashLoadingScreenResource == null)
				{
					_splashLoadingScreenResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "splashLoadingScreenResource", cr2w, this);
				}
				return _splashLoadingScreenResource;
			}
			set
			{
				if (_splashLoadingScreenResource == value)
				{
					return;
				}
				_splashLoadingScreenResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("initialLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> InitialLoadingScreenResource
		{
			get
			{
				if (_initialLoadingScreenResource == null)
				{
					_initialLoadingScreenResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "initialLoadingScreenResource", cr2w, this);
				}
				return _initialLoadingScreenResource;
			}
			set
			{
				if (_initialLoadingScreenResource == value)
				{
					return;
				}
				_initialLoadingScreenResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("fastTravelLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> FastTravelLoadingScreenResource
		{
			get
			{
				if (_fastTravelLoadingScreenResource == null)
				{
					_fastTravelLoadingScreenResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "fastTravelLoadingScreenResource", cr2w, this);
				}
				return _fastTravelLoadingScreenResource;
			}
			set
			{
				if (_fastTravelLoadingScreenResource == value)
				{
					return;
				}
				_fastTravelLoadingScreenResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("fallbackLoadingScreenResource")] 
		public raRef<inkWidgetLibraryResource> FallbackLoadingScreenResource
		{
			get
			{
				if (_fallbackLoadingScreenResource == null)
				{
					_fallbackLoadingScreenResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "fallbackLoadingScreenResource", cr2w, this);
				}
				return _fallbackLoadingScreenResource;
			}
			set
			{
				if (_fallbackLoadingScreenResource == value)
				{
					return;
				}
				_fallbackLoadingScreenResource = value;
				PropertySet(this);
			}
		}

		public inkLoadingLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
