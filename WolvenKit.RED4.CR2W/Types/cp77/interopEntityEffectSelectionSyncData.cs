using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopEntityEffectSelectionSyncData : CVariable
	{
		private CName _effectName;
		private toolsEditorObjectIDPath _effectIDPath;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectIDPath")] 
		public toolsEditorObjectIDPath EffectIDPath
		{
			get
			{
				if (_effectIDPath == null)
				{
					_effectIDPath = (toolsEditorObjectIDPath) CR2WTypeManager.Create("toolsEditorObjectIDPath", "effectIDPath", cr2w, this);
				}
				return _effectIDPath;
			}
			set
			{
				if (_effectIDPath == value)
				{
					return;
				}
				_effectIDPath = value;
				PropertySet(this);
			}
		}

		public interopEntityEffectSelectionSyncData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
