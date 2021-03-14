using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCacheWidget : inkCompoundWidget
	{
		private Vector2 _innerScale;
		private CEnum<inkCacheMode> _mode;
		private CName _externalDynamicTexture;

		[Ordinal(23)] 
		[RED("innerScale")] 
		public Vector2 InnerScale
		{
			get
			{
				if (_innerScale == null)
				{
					_innerScale = (Vector2) CR2WTypeManager.Create("Vector2", "innerScale", cr2w, this);
				}
				return _innerScale;
			}
			set
			{
				if (_innerScale == value)
				{
					return;
				}
				_innerScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("mode")] 
		public CEnum<inkCacheMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<inkCacheMode>) CR2WTypeManager.Create("inkCacheMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("externalDynamicTexture")] 
		public CName ExternalDynamicTexture
		{
			get
			{
				if (_externalDynamicTexture == null)
				{
					_externalDynamicTexture = (CName) CR2WTypeManager.Create("CName", "externalDynamicTexture", cr2w, this);
				}
				return _externalDynamicTexture;
			}
			set
			{
				if (_externalDynamicTexture == value)
				{
					return;
				}
				_externalDynamicTexture = value;
				PropertySet(this);
			}
		}

		public inkCacheWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
