using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
    public class gameSmartObjectAnimationDatabase : CVariable
    {
        private CInt32 _unknown1;
        private CArrayVLQInt32<gameAnimationExtractedData_> _animationData;
        private CArrayVLQInt32<gameBodyTypeData_> _bodyTypesData;
        private CArrayVLQInt32<gameSmartObjectAnimationDatabaseUnknownClass1> _unknown2;

        [Ordinal(0)]
        [REDBuffer(true)]
        public CInt32 Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1)]
        [REDBuffer(true)]
        public CArrayVLQInt32<gameAnimationExtractedData_> AnimationData
        {
            get => GetProperty(ref _animationData);
            set => SetProperty(ref _animationData, value);
        }

        [Ordinal(2)]
        [REDBuffer(true)]
        public CArrayVLQInt32<gameBodyTypeData_> BodyTypesData
        {
            get => GetProperty(ref _bodyTypesData);
            set => SetProperty(ref _bodyTypesData, value);
        }

        [Ordinal(3)]
        [REDBuffer(true)]
        public CArrayVLQInt32<gameSmartObjectAnimationDatabaseUnknownClass1> Unknown2
        {
            get => GetProperty(ref _unknown2);
            set => SetProperty(ref _unknown2, value);
        }

        public gameSmartObjectAnimationDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            cr2w.UnknownVars.Add(this.UniqueIdentifier);

            Unknown1.Read(file, size);
            AnimationData.ReadWithoutMeta(file, size);
            BodyTypesData.ReadWithoutMeta(file, size);
            Unknown2.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            Unknown1.WriteWithoutMeta(file);
            AnimationData.WriteWithoutMeta(file);
            BodyTypesData.WriteWithoutMeta(file);
            Unknown2.WriteWithoutMeta(file);
        }
    }

    public class gameAnimationExtractedData_ : CVariable
    {
        private CName _animationName;
        private CArrayVLQInt32<gameAnimationTransforms_> _animsetsExtractedTransforms;
        private CEnum<gameSmartObjectPointType> _smartObjectPointType;

        [Ordinal(0)]
        [REDBuffer(true)]
        public CName AnimationName
        {
            get => GetProperty(ref _animationName);
            set => SetProperty(ref _animationName, value);
        }

        [Ordinal(1)]
        [REDBuffer(true)]
        public CArrayVLQInt32<gameAnimationTransforms_> AnimsetsExtractedTransforms
        {
            get => GetProperty(ref _animsetsExtractedTransforms);
            set => SetProperty(ref _animsetsExtractedTransforms, value);
        }

        [Ordinal(2)]
        [REDBuffer(true)]
        public CEnum<gameSmartObjectPointType> SmartObjectPointType
        {
            get => GetProperty(ref _smartObjectPointType);
            set => SetProperty(ref _smartObjectPointType, value);
        }

        public gameAnimationExtractedData_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            AnimationName.ReadWithoutMeta(file, size);
            AnimationName.IsSerialized = true;

            AnimsetsExtractedTransforms.ReadWithoutMeta(file, size);
            SmartObjectPointType.Value = (gameSmartObjectPointType) file.ReadInt32();
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            AnimationName.WriteWithoutMeta(file);
            AnimsetsExtractedTransforms.WriteWithoutMeta(file);

            file.Write((int)SmartObjectPointType.Value);
        }
    }

    public class gameAnimationTransforms_ : CVariable
    {
        private CArrayVLQInt32<Transform> _extractedMotion;
        private Transform _gatePosition;
        private Transform _boneOffset;
        private CUInt64 _animsetHash;

        [Ordinal(0)]
        [REDBuffer(true)]
        public CArrayVLQInt32<Transform> ExtractedMotion
        {
            get => GetProperty(ref _extractedMotion);
            set => SetProperty(ref _extractedMotion, value);
        }

        [Ordinal(1)]
        [REDBuffer(true)]
        public Transform GatePosition
        {
            get => GetProperty(ref _gatePosition);
            set => SetProperty(ref _gatePosition, value);
        }

        [Ordinal(2)]
        [REDBuffer(true)]
        public Transform BoneOffset
        {
            get => GetProperty(ref _boneOffset);
            set => SetProperty(ref _boneOffset, value);
        }

        [Ordinal(3)]
        [REDBuffer(true)]
        public CUInt64 AnimsetHash
        {
            get => GetProperty(ref _animsetHash);
            set => SetProperty(ref _animsetHash, value);
        }

        public gameAnimationTransforms_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            ExtractedMotion.ReadWithoutMeta(file, size);
            GatePosition.ReadWithoutMeta(file, size);
            BoneOffset.ReadWithoutMeta(file, size);
            AnimsetHash.ReadWithoutMeta(file, size);
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            ExtractedMotion.WriteWithoutMeta(file);
            GatePosition.WriteWithoutMeta(file);
            BoneOffset.WriteWithoutMeta(file);
            AnimsetHash.WriteWithoutMeta(file);
        }
    }

    public class gameBodyTypeData_ : CVariable
    {
        private CUInt64 _rigHash;
        private CArrayVLQInt32<CUInt64> _animsetHashes;
        private CArrayVLQInt32<gameAnimsetOverrideData_> _overrides;

        [Ordinal(0)]
        [REDBuffer(true)]
        public CUInt64 RigHash
        {
            get => GetProperty(ref _rigHash);
            set => SetProperty(ref _rigHash, value);
        }

        [Ordinal(1)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CUInt64> AnimsetHashes
        {
            get => GetProperty(ref _animsetHashes);
            set => SetProperty(ref _animsetHashes, value);
        }

        [Ordinal(2)]
        [REDBuffer(true)]
        public CArrayVLQInt32<gameAnimsetOverrideData_> Overrides
        {
            get => GetProperty(ref _overrides);
            set => SetProperty(ref _overrides, value);
        }

        public gameBodyTypeData_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            RigHash.ReadWithoutMeta(file, size);
            AnimsetHashes.ReadWithoutMeta(file, size);
            Overrides.ReadWithoutMeta(file, size);
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            RigHash.WriteWithoutMeta(file);
            AnimsetHashes.WriteWithoutMeta(file);
            Overrides.WriteWithoutMeta(file);
        }
    }

    public class gameAnimsetOverrideData_ : CVariable
    {
        private CUInt64 _animsetHash;
        private CArrayVLQInt32<CName> _variables;

        [Ordinal(0)]
        [REDBuffer(true)]
        public CUInt64 AnimsetHash
        {
            get => GetProperty(ref _animsetHash);
            set => SetProperty(ref _animsetHash, value);
        }

        [Ordinal(1)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CName> Variables
        {
            get => GetProperty(ref _variables);
            set => SetProperty(ref _variables, value);
        }

        public gameAnimsetOverrideData_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            AnimsetHash.ReadWithoutMeta(file, size);
            Variables.ReadWithoutMeta(file, size);
            foreach (var variable in Variables)
            {
                variable.IsSerialized = true;
            }
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            AnimsetHash.WriteWithoutMeta(file);
            Variables.WriteWithoutMeta(file);
        }
    }

    public class gameSmartObjectAnimationDatabaseUnknownClass1 : CVariable
    {
        private CUInt64 _animsetHash;
        private CString _animsetPath;

        [Ordinal(0)]
        [REDBuffer(true)]
        public CUInt64 AnimsetHash
        {
            get => GetProperty(ref _animsetHash);
            set => SetProperty(ref _animsetHash, value);
        }

        [Ordinal(1)]
        [REDBuffer(true)]
        public CString AnimsetPath
        {
            get => GetProperty(ref _animsetPath);
            set => SetProperty(ref _animsetPath, value);
        }

        public gameSmartObjectAnimationDatabaseUnknownClass1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            AnimsetHash.ReadWithoutMeta(file, size);
            AnimsetPath.ReadWithoutMeta(file, size);
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            AnimsetHash.WriteWithoutMeta(file);
            AnimsetPath.WriteWithoutMeta(file);
        }
    }
}
