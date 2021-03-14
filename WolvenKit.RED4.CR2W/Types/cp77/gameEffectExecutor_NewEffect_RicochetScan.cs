using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_NewEffect_RicochetScan : gameEffectExecutor_NewEffect
	{
		private Vector4 _box;
		private CBool _isPreview;

		[Ordinal(5)] 
		[RED("box")] 
		public Vector4 Box
		{
			get
			{
				if (_box == null)
				{
					_box = (Vector4) CR2WTypeManager.Create("Vector4", "box", cr2w, this);
				}
				return _box;
			}
			set
			{
				if (_box == value)
				{
					return;
				}
				_box = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get
			{
				if (_isPreview == null)
				{
					_isPreview = (CBool) CR2WTypeManager.Create("Bool", "isPreview", cr2w, this);
				}
				return _isPreview;
			}
			set
			{
				if (_isPreview == value)
				{
					return;
				}
				_isPreview = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_NewEffect_RicochetScan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
