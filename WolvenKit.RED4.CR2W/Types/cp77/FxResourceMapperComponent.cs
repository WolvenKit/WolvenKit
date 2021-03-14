using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FxResourceMapperComponent : gameScriptableComponent
	{
		private CArray<SAreaEffectData> _areaEffectsData;
		private CArray<SAreaEffectTargetData> _areaEffectsInFocusMode;
		private CArray<CHandle<AreaEffectData>> _areaEffectData;
		private CFloat _investigationSlotOffsetMultiplier;
		private CArray<CHandle<AreaEffectTargetData>> _areaEffectInFocusMode;
		private CBool _dEBUG_copiedDataFromEntity;
		private CBool _dEBUG_copiedDataFromFXStruct;

		[Ordinal(5)] 
		[RED("areaEffectsData")] 
		public CArray<SAreaEffectData> AreaEffectsData
		{
			get
			{
				if (_areaEffectsData == null)
				{
					_areaEffectsData = (CArray<SAreaEffectData>) CR2WTypeManager.Create("array:SAreaEffectData", "areaEffectsData", cr2w, this);
				}
				return _areaEffectsData;
			}
			set
			{
				if (_areaEffectsData == value)
				{
					return;
				}
				_areaEffectsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("areaEffectsInFocusMode")] 
		public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode
		{
			get
			{
				if (_areaEffectsInFocusMode == null)
				{
					_areaEffectsInFocusMode = (CArray<SAreaEffectTargetData>) CR2WTypeManager.Create("array:SAreaEffectTargetData", "areaEffectsInFocusMode", cr2w, this);
				}
				return _areaEffectsInFocusMode;
			}
			set
			{
				if (_areaEffectsInFocusMode == value)
				{
					return;
				}
				_areaEffectsInFocusMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("areaEffectData")] 
		public CArray<CHandle<AreaEffectData>> AreaEffectData
		{
			get
			{
				if (_areaEffectData == null)
				{
					_areaEffectData = (CArray<CHandle<AreaEffectData>>) CR2WTypeManager.Create("array:handle:AreaEffectData", "areaEffectData", cr2w, this);
				}
				return _areaEffectData;
			}
			set
			{
				if (_areaEffectData == value)
				{
					return;
				}
				_areaEffectData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("investigationSlotOffsetMultiplier")] 
		public CFloat InvestigationSlotOffsetMultiplier
		{
			get
			{
				if (_investigationSlotOffsetMultiplier == null)
				{
					_investigationSlotOffsetMultiplier = (CFloat) CR2WTypeManager.Create("Float", "investigationSlotOffsetMultiplier", cr2w, this);
				}
				return _investigationSlotOffsetMultiplier;
			}
			set
			{
				if (_investigationSlotOffsetMultiplier == value)
				{
					return;
				}
				_investigationSlotOffsetMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("areaEffectInFocusMode")] 
		public CArray<CHandle<AreaEffectTargetData>> AreaEffectInFocusMode
		{
			get
			{
				if (_areaEffectInFocusMode == null)
				{
					_areaEffectInFocusMode = (CArray<CHandle<AreaEffectTargetData>>) CR2WTypeManager.Create("array:handle:AreaEffectTargetData", "areaEffectInFocusMode", cr2w, this);
				}
				return _areaEffectInFocusMode;
			}
			set
			{
				if (_areaEffectInFocusMode == value)
				{
					return;
				}
				_areaEffectInFocusMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("DEBUG_copiedDataFromEntity")] 
		public CBool DEBUG_copiedDataFromEntity
		{
			get
			{
				if (_dEBUG_copiedDataFromEntity == null)
				{
					_dEBUG_copiedDataFromEntity = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_copiedDataFromEntity", cr2w, this);
				}
				return _dEBUG_copiedDataFromEntity;
			}
			set
			{
				if (_dEBUG_copiedDataFromEntity == value)
				{
					return;
				}
				_dEBUG_copiedDataFromEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("DEBUG_copiedDataFromFXStruct")] 
		public CBool DEBUG_copiedDataFromFXStruct
		{
			get
			{
				if (_dEBUG_copiedDataFromFXStruct == null)
				{
					_dEBUG_copiedDataFromFXStruct = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_copiedDataFromFXStruct", cr2w, this);
				}
				return _dEBUG_copiedDataFromFXStruct;
			}
			set
			{
				if (_dEBUG_copiedDataFromFXStruct == value)
				{
					return;
				}
				_dEBUG_copiedDataFromFXStruct = value;
				PropertySet(this);
			}
		}

		public FxResourceMapperComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
