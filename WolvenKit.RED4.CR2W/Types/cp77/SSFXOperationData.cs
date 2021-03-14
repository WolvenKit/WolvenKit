using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSFXOperationData : CVariable
	{
		private CName _sfxName;
		private CEnum<EEffectOperationType> _operationType;

		[Ordinal(0)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get
			{
				if (_sfxName == null)
				{
					_sfxName = (CName) CR2WTypeManager.Create("CName", "sfxName", cr2w, this);
				}
				return _sfxName;
			}
			set
			{
				if (_sfxName == value)
				{
					return;
				}
				_sfxName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EEffectOperationType>) CR2WTypeManager.Create("EEffectOperationType", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		public SSFXOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
