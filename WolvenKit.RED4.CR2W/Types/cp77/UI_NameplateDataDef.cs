using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NameplateDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _entityID;
		private gamebbScriptID_Bool _isVisible;
		private gamebbScriptID_Float _heightOffset;
		private gamebbScriptID_Int32 _damageProjection;

		[Ordinal(0)] 
		[RED("EntityID")] 
		public gamebbScriptID_Variant EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "EntityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IsVisible")] 
		public gamebbScriptID_Bool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("HeightOffset")] 
		public gamebbScriptID_Float HeightOffset
		{
			get
			{
				if (_heightOffset == null)
				{
					_heightOffset = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "HeightOffset", cr2w, this);
				}
				return _heightOffset;
			}
			set
			{
				if (_heightOffset == value)
				{
					return;
				}
				_heightOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("DamageProjection")] 
		public gamebbScriptID_Int32 DamageProjection
		{
			get
			{
				if (_damageProjection == null)
				{
					_damageProjection = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "DamageProjection", cr2w, this);
				}
				return _damageProjection;
			}
			set
			{
				if (_damageProjection == value)
				{
					return;
				}
				_damageProjection = value;
				PropertySet(this);
			}
		}

		public UI_NameplateDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
