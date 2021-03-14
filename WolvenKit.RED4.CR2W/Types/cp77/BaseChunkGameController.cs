using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseChunkGameController : gameuiWidgetGameController
	{
		private CHandle<gameIBlackboard> _chunkBlackboard;
		private CHandle<UI_ScannerModulesDef> _chunkBlackboardDef;
		private CHandle<UI_ScannerDef> _questClueBlackboardDef;

		[Ordinal(2)] 
		[RED("chunkBlackboard")] 
		public CHandle<gameIBlackboard> ChunkBlackboard
		{
			get
			{
				if (_chunkBlackboard == null)
				{
					_chunkBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "chunkBlackboard", cr2w, this);
				}
				return _chunkBlackboard;
			}
			set
			{
				if (_chunkBlackboard == value)
				{
					return;
				}
				_chunkBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("chunkBlackboardDef")] 
		public CHandle<UI_ScannerModulesDef> ChunkBlackboardDef
		{
			get
			{
				if (_chunkBlackboardDef == null)
				{
					_chunkBlackboardDef = (CHandle<UI_ScannerModulesDef>) CR2WTypeManager.Create("handle:UI_ScannerModulesDef", "chunkBlackboardDef", cr2w, this);
				}
				return _chunkBlackboardDef;
			}
			set
			{
				if (_chunkBlackboardDef == value)
				{
					return;
				}
				_chunkBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("questClueBlackboardDef")] 
		public CHandle<UI_ScannerDef> QuestClueBlackboardDef
		{
			get
			{
				if (_questClueBlackboardDef == null)
				{
					_questClueBlackboardDef = (CHandle<UI_ScannerDef>) CR2WTypeManager.Create("handle:UI_ScannerDef", "questClueBlackboardDef", cr2w, this);
				}
				return _questClueBlackboardDef;
			}
			set
			{
				if (_questClueBlackboardDef == value)
				{
					return;
				}
				_questClueBlackboardDef = value;
				PropertySet(this);
			}
		}

		public BaseChunkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
