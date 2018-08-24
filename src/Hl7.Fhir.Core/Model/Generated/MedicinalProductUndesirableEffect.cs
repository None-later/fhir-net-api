﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

#pragma warning disable 1591 // suppress XML summary warnings 

//
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// MedicinalProductUndesirableEffect
    /// </summary>
    [FhirType("MedicinalProductUndesirableEffect", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductUndesirableEffect : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductUndesirableEffect; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductUndesirableEffect"; } }
        
        [FhirType("PopulationComponent")]
        [DataContract]
        public partial class PopulationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PopulationComponent"; } }
            
            /// <summary>
            /// The age of the specific population
            /// </summary>
            [FhirElement("age", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element Age
            {
                get { return _Age; }
                set { _Age = value; OnPropertyChanged("Age"); }
            }
            
            private Hl7.Fhir.Model.Element _Age;
            
            /// <summary>
            /// The gender of the specific population
            /// </summary>
            [FhirElement("gender", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Gender
            {
                get { return _Gender; }
                set { _Gender = value; OnPropertyChanged("Gender"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Gender;
            
            /// <summary>
            /// Race of the specific population
            /// </summary>
            [FhirElement("race", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Race
            {
                get { return _Race; }
                set { _Race = value; OnPropertyChanged("Race"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Race;
            
            /// <summary>
            /// The existing physiological conditions of the specific population to which this applies
            /// </summary>
            [FhirElement("physiologicalCondition", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept PhysiologicalCondition
            {
                get { return _PhysiologicalCondition; }
                set { _PhysiologicalCondition = value; OnPropertyChanged("PhysiologicalCondition"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _PhysiologicalCondition;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PopulationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Age != null) dest.Age = (Hl7.Fhir.Model.Element)Age.DeepCopy();
                    if(Gender != null) dest.Gender = (Hl7.Fhir.Model.CodeableConcept)Gender.DeepCopy();
                    if(Race != null) dest.Race = (Hl7.Fhir.Model.CodeableConcept)Race.DeepCopy();
                    if(PhysiologicalCondition != null) dest.PhysiologicalCondition = (Hl7.Fhir.Model.CodeableConcept)PhysiologicalCondition.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PopulationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Age, otherT.Age)) return false;
                if( !DeepComparable.Matches(Gender, otherT.Gender)) return false;
                if( !DeepComparable.Matches(Race, otherT.Race)) return false;
                if( !DeepComparable.Matches(PhysiologicalCondition, otherT.PhysiologicalCondition)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Age, otherT.Age)) return false;
                if( !DeepComparable.IsExactly(Gender, otherT.Gender)) return false;
                if( !DeepComparable.IsExactly(Race, otherT.Race)) return false;
                if( !DeepComparable.IsExactly(PhysiologicalCondition, otherT.PhysiologicalCondition)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Age != null) yield return Age;
                    if (Gender != null) yield return Gender;
                    if (Race != null) yield return Race;
                    if (PhysiologicalCondition != null) yield return PhysiologicalCondition;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Age != null) yield return new ElementValue("age", false, Age);
                    if (Gender != null) yield return new ElementValue("gender", false, Gender);
                    if (Race != null) yield return new ElementValue("race", false, Race);
                    if (PhysiologicalCondition != null) yield return new ElementValue("physiologicalCondition", false, PhysiologicalCondition);
                }
            }

            
        }
        
        
        /// <summary>
        /// The medication for which this is an indication
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=90)]
        [CLSCompliant(false)]
		[References("MedicinalProduct","Medication")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Subject
        {
            get { if(_Subject==null) _Subject = new List<Hl7.Fhir.Model.ResourceReference>(); return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Subject;
        
        /// <summary>
        /// The symptom, condition or undesirable effect
        /// </summary>
        [FhirElement("symptomConditionEffect", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept SymptomConditionEffect
        {
            get { return _SymptomConditionEffect; }
            set { _SymptomConditionEffect = value; OnPropertyChanged("SymptomConditionEffect"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _SymptomConditionEffect;
        
        /// <summary>
        /// Classification of the effect
        /// </summary>
        [FhirElement("classification", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Classification
        {
            get { return _Classification; }
            set { _Classification = value; OnPropertyChanged("Classification"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Classification;
        
        /// <summary>
        /// The frequency of occurrence of the effect
        /// </summary>
        [FhirElement("frequencyOfOccurrence", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept FrequencyOfOccurrence
        {
            get { return _FrequencyOfOccurrence; }
            set { _FrequencyOfOccurrence = value; OnPropertyChanged("FrequencyOfOccurrence"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _FrequencyOfOccurrence;
        
        /// <summary>
        /// The population group to which this applies
        /// </summary>
        [FhirElement("population", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.MedicinalProductUndesirableEffect.PopulationComponent> Population
        {
            get { if(_Population==null) _Population = new List<Hl7.Fhir.Model.MedicinalProductUndesirableEffect.PopulationComponent>(); return _Population; }
            set { _Population = value; OnPropertyChanged("Population"); }
        }
        
        private List<Hl7.Fhir.Model.MedicinalProductUndesirableEffect.PopulationComponent> _Population;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductUndesirableEffect;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Subject != null) dest.Subject = new List<Hl7.Fhir.Model.ResourceReference>(Subject.DeepCopy());
                if(SymptomConditionEffect != null) dest.SymptomConditionEffect = (Hl7.Fhir.Model.CodeableConcept)SymptomConditionEffect.DeepCopy();
                if(Classification != null) dest.Classification = (Hl7.Fhir.Model.CodeableConcept)Classification.DeepCopy();
                if(FrequencyOfOccurrence != null) dest.FrequencyOfOccurrence = (Hl7.Fhir.Model.CodeableConcept)FrequencyOfOccurrence.DeepCopy();
                if(Population != null) dest.Population = new List<Hl7.Fhir.Model.MedicinalProductUndesirableEffect.PopulationComponent>(Population.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new MedicinalProductUndesirableEffect());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductUndesirableEffect;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(SymptomConditionEffect, otherT.SymptomConditionEffect)) return false;
            if( !DeepComparable.Matches(Classification, otherT.Classification)) return false;
            if( !DeepComparable.Matches(FrequencyOfOccurrence, otherT.FrequencyOfOccurrence)) return false;
            if( !DeepComparable.Matches(Population, otherT.Population)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductUndesirableEffect;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(SymptomConditionEffect, otherT.SymptomConditionEffect)) return false;
            if( !DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
            if( !DeepComparable.IsExactly(FrequencyOfOccurrence, otherT.FrequencyOfOccurrence)) return false;
            if( !DeepComparable.IsExactly(Population, otherT.Population)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				foreach (var elem in Subject) { if (elem != null) yield return elem; }
				if (SymptomConditionEffect != null) yield return SymptomConditionEffect;
				if (Classification != null) yield return Classification;
				if (FrequencyOfOccurrence != null) yield return FrequencyOfOccurrence;
				foreach (var elem in Population) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", true, elem); }
                if (SymptomConditionEffect != null) yield return new ElementValue("symptomConditionEffect", false, SymptomConditionEffect);
                if (Classification != null) yield return new ElementValue("classification", false, Classification);
                if (FrequencyOfOccurrence != null) yield return new ElementValue("frequencyOfOccurrence", false, FrequencyOfOccurrence);
                foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", true, elem); }
            }
        }

    }
    
}