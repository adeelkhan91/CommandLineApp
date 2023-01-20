import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule, FormBuilder } from '@angular/forms';
import { RouterTestingModule } from '@angular/router/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';

describe('CountriesFormComponent', () => {
  let component;
  let fixture: ComponentFixture<string>;
  let fb: FormBuilder;
  let spinnerService;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ReactiveFormsModule, RouterTestingModule, HttpClientTestingModule],
      declarations: [],
      providers: [FormBuilder]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(component);
    component = fixture.componentInstance;
    fb = TestBed.get(FormBuilder);

    component.countryListForm = fb.group({
      country: [''],
      filterOptions: ['Name'],
      countries: ['allcountries'],
      region: ['allregions'],
    });
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should initialize form on ngOnInit', () => {
    spyOn(component, 'getAllCounriesInfo');
    spyOn(component, 'updatedSearchValue');
    spyOn(component, 'getDarkModeStatus');
    component.ngOnInit();
    expect(component.getAllCounriesInfo).toHaveBeenCalled();
    expect(component.updatedSearchValue).toHaveBeenCalled();
    expect(component.getDarkModeStatus).toHaveBeenCalled();
  });

  it('should get all countries data', () => {
    spyOn(spinnerService, 'show');
    spyOn(spinnerService, 'hide');
    component.getAllCounriesInfo();
    expect(spinnerService.show).toHaveBeenCalled();
    expect(component.allCountriesList).toEqual([{name: 'London'}]);
    expect(component.totalLength).toEqual(1);
    expect(spinnerService.hide).toHaveBeenCalled();
  }
  )
  }
)
