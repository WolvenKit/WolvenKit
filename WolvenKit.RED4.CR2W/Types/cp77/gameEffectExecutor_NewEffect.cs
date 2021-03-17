using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_NewEffect : gameEffectExecutor
	{
		private CName _tagInThisFile;
		private CFloat _forwardOffset;
		private CBool _childEffect;
		private CName _childEffectTag;

		[Ordinal(1)] 
		[RED("tagInThisFile")] 
		public CName TagInThisFile
		{
			get => GetProperty(ref _tagInThisFile);
			set => SetProperty(ref _tagInThisFile, value);
		}

		[Ordinal(2)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get => GetProperty(ref _forwardOffset);
			set => SetProperty(ref _forwardOffset, value);
		}

		[Ordinal(3)] 
		[RED("childEffect")] 
		public CBool ChildEffect
		{
			get => GetProperty(ref _childEffect);
			set => SetProperty(ref _childEffect, value);
		}

		[Ordinal(4)] 
		[RED("childEffectTag")] 
		public CName ChildEffectTag
		{
			get => GetProperty(ref _childEffectTag);
			set => SetProperty(ref _childEffectTag, value);
		}

		public gameEffectExecutor_NewEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
