using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEnvironmentAreaParameters : CResource
	{
		private WorldRenderAreaSettings _renderAreaSettings;
		private CBool _resaved;

		[Ordinal(1)] 
		[RED("renderAreaSettings")] 
		public WorldRenderAreaSettings RenderAreaSettings
		{
			get
			{
				if (_renderAreaSettings == null)
				{
					_renderAreaSettings = (WorldRenderAreaSettings) CR2WTypeManager.Create("WorldRenderAreaSettings", "renderAreaSettings", cr2w, this);
				}
				return _renderAreaSettings;
			}
			set
			{
				if (_renderAreaSettings == value)
				{
					return;
				}
				_renderAreaSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("resaved")] 
		public CBool Resaved
		{
			get
			{
				if (_resaved == null)
				{
					_resaved = (CBool) CR2WTypeManager.Create("Bool", "resaved", cr2w, this);
				}
				return _resaved;
			}
			set
			{
				if (_resaved == value)
				{
					return;
				}
				_resaved = value;
				PropertySet(this);
			}
		}

		public worldEnvironmentAreaParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
