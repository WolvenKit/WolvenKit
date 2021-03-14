using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageCacheData : IScriptable
	{
		private CEnum<gameGodModeType> _targetImmortalityMode;
		private CBool _tEMP_ImmortalityCached;
		private CInt64 _logFlags;

		[Ordinal(0)] 
		[RED("targetImmortalityMode")] 
		public CEnum<gameGodModeType> TargetImmortalityMode
		{
			get
			{
				if (_targetImmortalityMode == null)
				{
					_targetImmortalityMode = (CEnum<gameGodModeType>) CR2WTypeManager.Create("gameGodModeType", "targetImmortalityMode", cr2w, this);
				}
				return _targetImmortalityMode;
			}
			set
			{
				if (_targetImmortalityMode == value)
				{
					return;
				}
				_targetImmortalityMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("TEMP_ImmortalityCached")] 
		public CBool TEMP_ImmortalityCached
		{
			get
			{
				if (_tEMP_ImmortalityCached == null)
				{
					_tEMP_ImmortalityCached = (CBool) CR2WTypeManager.Create("Bool", "TEMP_ImmortalityCached", cr2w, this);
				}
				return _tEMP_ImmortalityCached;
			}
			set
			{
				if (_tEMP_ImmortalityCached == value)
				{
					return;
				}
				_tEMP_ImmortalityCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("logFlags")] 
		public CInt64 LogFlags
		{
			get
			{
				if (_logFlags == null)
				{
					_logFlags = (CInt64) CR2WTypeManager.Create("Int64", "logFlags", cr2w, this);
				}
				return _logFlags;
			}
			set
			{
				if (_logFlags == value)
				{
					return;
				}
				_logFlags = value;
				PropertySet(this);
			}
		}

		public gamedamageCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
