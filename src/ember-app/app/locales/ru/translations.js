import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISPrilozhenieГородLForm from './forms/i-i-s-prilozhenie-город-l';
import IISPrilozhenieЗданиеLForm from './forms/i-i-s-prilozhenie-здание-l';
import IISPrilozhenieГородEForm from './forms/i-i-s-prilozhenie-город-e';
import IISPrilozhenieЗданиеEForm from './forms/i-i-s-prilozhenie-здание-e';
import IISPrilozhenieГородModel from './models/i-i-s-prilozhenie-город';
import IISPrilozhenieЗданиеModel from './models/i-i-s-prilozhenie-здание';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-prilozhenie-город': IISPrilozhenieГородModel,
    'i-i-s-prilozhenie-здание': IISPrilozhenieЗданиеModel
  },

  'application-name': 'Prilozhenie',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Prilozhenie',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Prilozhenie',
          title: 'Prilozhenie'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        prilozhenie: {
          caption: 'Prilozhenie',
          title: 'Prilozhenie',
          'i-i-s-prilozhenie-город-l': {
            caption: 'Город',
            title: ''
          },
          'i-i-s-prilozhenie-здание-l': {
            caption: 'Здание',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-prilozhenie-город-l': IISPrilozhenieГородLForm,
    'i-i-s-prilozhenie-здание-l': IISPrilozhenieЗданиеLForm,
    'i-i-s-prilozhenie-город-e': IISPrilozhenieГородEForm,
    'i-i-s-prilozhenie-здание-e': IISPrilozhenieЗданиеEForm
  },

});

export default translations;
