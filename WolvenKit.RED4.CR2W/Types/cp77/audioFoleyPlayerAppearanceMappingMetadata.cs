using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyPlayerAppearanceMappingMetadata : audioAudioMetadata
	{
		private CName _fallbackMetadata;
		private CArray<audioAppearanceToPlayerMetadata> _jacketSettings;
		private CArray<audioAppearanceToPlayerMetadata> _topSettings;
		private CArray<audioAppearanceToPlayerMetadata> _bottomSettings;
		private CArray<audioAppearanceToPlayerMetadata> _jewelrySettings;

		[Ordinal(1)] 
		[RED("fallbackMetadata")] 
		public CName FallbackMetadata
		{
			get
			{
				if (_fallbackMetadata == null)
				{
					_fallbackMetadata = (CName) CR2WTypeManager.Create("CName", "fallbackMetadata", cr2w, this);
				}
				return _fallbackMetadata;
			}
			set
			{
				if (_fallbackMetadata == value)
				{
					return;
				}
				_fallbackMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("jacketSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> JacketSettings
		{
			get
			{
				if (_jacketSettings == null)
				{
					_jacketSettings = (CArray<audioAppearanceToPlayerMetadata>) CR2WTypeManager.Create("array:audioAppearanceToPlayerMetadata", "jacketSettings", cr2w, this);
				}
				return _jacketSettings;
			}
			set
			{
				if (_jacketSettings == value)
				{
					return;
				}
				_jacketSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("topSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> TopSettings
		{
			get
			{
				if (_topSettings == null)
				{
					_topSettings = (CArray<audioAppearanceToPlayerMetadata>) CR2WTypeManager.Create("array:audioAppearanceToPlayerMetadata", "topSettings", cr2w, this);
				}
				return _topSettings;
			}
			set
			{
				if (_topSettings == value)
				{
					return;
				}
				_topSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bottomSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> BottomSettings
		{
			get
			{
				if (_bottomSettings == null)
				{
					_bottomSettings = (CArray<audioAppearanceToPlayerMetadata>) CR2WTypeManager.Create("array:audioAppearanceToPlayerMetadata", "bottomSettings", cr2w, this);
				}
				return _bottomSettings;
			}
			set
			{
				if (_bottomSettings == value)
				{
					return;
				}
				_bottomSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("jewelrySettings")] 
		public CArray<audioAppearanceToPlayerMetadata> JewelrySettings
		{
			get
			{
				if (_jewelrySettings == null)
				{
					_jewelrySettings = (CArray<audioAppearanceToPlayerMetadata>) CR2WTypeManager.Create("array:audioAppearanceToPlayerMetadata", "jewelrySettings", cr2w, this);
				}
				return _jewelrySettings;
			}
			set
			{
				if (_jewelrySettings == value)
				{
					return;
				}
				_jewelrySettings = value;
				PropertySet(this);
			}
		}

		public audioFoleyPlayerAppearanceMappingMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
