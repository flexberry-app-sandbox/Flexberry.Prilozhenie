import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  воЭтажей: DS.attr('number'),
  номер: DS.attr('number'),
  город: DS.belongsTo('i-i-s-prilozhenie-город', { inverse: null, async: false })
});

export let ValidationRules = {
  воЭтажей: {
    descriptionKey: 'models.i-i-s-prilozhenie-здание.validations.воЭтажей.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  номер: {
    descriptionKey: 'models.i-i-s-prilozhenie-здание.validations.номер.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  город: {
    descriptionKey: 'models.i-i-s-prilozhenie-здание.validations.город.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ЗданиеE', 'i-i-s-prilozhenie-здание', {
    номер: attr('Номер', { index: 0 }),
    город: belongsTo('i-i-s-prilozhenie-город', 'Город', {
      наименование: attr('Наименование', { index: 2, hidden: true })
    }, { index: 1, displayMemberPath: 'наименование' })
  });

  modelClass.defineProjection('ЗданиеL', 'i-i-s-prilozhenie-здание', {
    номер: attr('Номер', { index: 0 }),
    город: belongsTo('i-i-s-prilozhenie-город', 'Наименование', {
      наименование: attr('Наименование', { index: 1 })
    }, { index: -1, hidden: true })
  });
};
