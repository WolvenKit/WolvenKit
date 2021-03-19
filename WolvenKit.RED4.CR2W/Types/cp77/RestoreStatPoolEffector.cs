using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RestoreStatPoolEffector : gameEffector
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _valueToRestore;
		private CBool _percentage;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(1)] 
		[RED("valueToRestore")] 
		public CFloat ValueToRestore
		{
			get => GetProperty(ref _valueToRestore);
			set => SetProperty(ref _valueToRestore, value);
		}

		[Ordinal(2)] 
		[RED("percentage")] 
		public CBool Percentage
		{
			get => GetProperty(ref _percentage);
			set => SetProperty(ref _percentage, value);
		}

		public RestoreStatPoolEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
