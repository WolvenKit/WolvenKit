using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPermanentLayerDefinitionCollection : CVariable
	{
		private inkLoadingLayerDefinition _loadingLayer;
		private inkWatermarksLayerDefinition _watermarksLayer;
		private inkSystemNotificationsLayerDefinition _sysNotificationsLayer;

		[Ordinal(0)] 
		[RED("loadingLayer")] 
		public inkLoadingLayerDefinition LoadingLayer
		{
			get
			{
				if (_loadingLayer == null)
				{
					_loadingLayer = (inkLoadingLayerDefinition) CR2WTypeManager.Create("inkLoadingLayerDefinition", "loadingLayer", cr2w, this);
				}
				return _loadingLayer;
			}
			set
			{
				if (_loadingLayer == value)
				{
					return;
				}
				_loadingLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("watermarksLayer")] 
		public inkWatermarksLayerDefinition WatermarksLayer
		{
			get
			{
				if (_watermarksLayer == null)
				{
					_watermarksLayer = (inkWatermarksLayerDefinition) CR2WTypeManager.Create("inkWatermarksLayerDefinition", "watermarksLayer", cr2w, this);
				}
				return _watermarksLayer;
			}
			set
			{
				if (_watermarksLayer == value)
				{
					return;
				}
				_watermarksLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sysNotificationsLayer")] 
		public inkSystemNotificationsLayerDefinition SysNotificationsLayer
		{
			get
			{
				if (_sysNotificationsLayer == null)
				{
					_sysNotificationsLayer = (inkSystemNotificationsLayerDefinition) CR2WTypeManager.Create("inkSystemNotificationsLayerDefinition", "sysNotificationsLayer", cr2w, this);
				}
				return _sysNotificationsLayer;
			}
			set
			{
				if (_sysNotificationsLayer == value)
				{
					return;
				}
				_sysNotificationsLayer = value;
				PropertySet(this);
			}
		}

		public inkPermanentLayerDefinitionCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
